using System;

namespace Inheritance
{
    // TODO: Declarar "Magazine" como subclass de Publication
    class Magazine : Publication
    {
        private string _publisher;

        // base() keyword usada para iniciar el base class
        public Magazine(string name, string publisher, int pagecount, decimal price)
            :base(name, pagecount, price)
        {
            _publisher = publisher;
        }

        public string Publisher
        {
            get => _publisher;
            set => _publisher = value;
        }
    }
}
