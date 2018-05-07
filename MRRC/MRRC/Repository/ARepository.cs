using MRRC.Domain;
using MRRC.Domain.Exceptions;
using MRRC.Domain.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRC.Repository
{
    public abstract class ARepository<T>
    {
        // The headers for the lists
        protected String[] _header;

        // The actual items
        protected List<T> _items;

        // The validator for the CRUD
        IValidator<T> _validator;

        public ARepository(IValidator<T> validator)
        {
            _items = new List<T>();
            _validator = validator;
            LoadFromFile();
        }

        protected abstract void LoadFromFile();

        public void Add(T item)
        {
            // Try to check if the item is valid
            /// <exception cref="RepositoryException">If the entity cannot be validated.</exception>
            try
            {
                _validator.Validate(item);
            } catch (ValidatorException validatorException)
            {
                // Propagate the message
                throw new RepositoryException(validatorException.Message);
            }

            // Add the item to the list
            _items.Add(item);
        }

        public void Update(T item)
        {
            // Search for the index of the item
            int index;
            for (index = 0; index < _items.Count; index++) if (_items[index].Equals(item)) break;

            // Replace the old item with the new one 
            _items[index] = item;
        }

        /// <exception cref="RepositoryException">If the entity doesn't exist in the list.</exception>
        public void Delete(T item)
        {
            // Check if item is in the big list, throw an exception otherwise.
            if (!Items.Contains(item)) throw new RepositoryException("Item does not exist in the list!");

            // Remove the item from the list
            Items.Remove(item);
        }

        public String[] Header { get => _header; }
        public List<T> Items { get => _items; }
    }
}
