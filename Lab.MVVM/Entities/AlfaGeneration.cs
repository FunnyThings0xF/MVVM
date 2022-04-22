using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lab.MVVM.Interfaces;

namespace Lab.MVVM.Entities
{
    public class AlfaGeneration : IPhone
    {
        private IDictionary<string, IDeviceProperty> _properties;
        private IList<IApplication> _applications;
        private readonly Guid _guid;
        private string _description;
        private int _lifestatus;
        private string _name;

        public AlfaGeneration()
        {

        }
        public AlfaGeneration(string name, string description)
        {
            _properties = new Dictionary<string, IDeviceProperty>();
            _applications = new List<IApplication>();
            _guid = Guid.NewGuid();
            _description = description;
            _name = name;
            _lifestatus = 100;
        }

        public string Cover
        {
            get => _properties["Cover"].Value.ToString();
            set => _properties["Conver"].Value = value;
        }
        public int LifeStatus
        {
            get => _lifestatus;
            set => _lifestatus -= (value + 5);
        }

        public Guid Guid { get => _guid; }

        public string Name => nameof(AlfaGeneration) +  _name;

        public string Description =>  _description;

        public IDeviceProperty GetProperty()
        {
            return _properties.FirstOrDefault().Value;
        }

        public void Install(IApplication application)
        {
            _applications.Add(application);
        }

        public void Remove(IApplication application)
        {
            _applications.Remove(application);
        }

        public void SetProperty(IDeviceProperty property)
        {

        }

        public void Use()
        {
            LifeStatus = -1;
        }
    }  
    public class AlfaGenerationApplication : IApplication
    {
        private long _size;
        private string _name;
        private string _category;
        
        public string Name { get => _name; set => _name = value; }
        public string Category { get => _category; set => _category = value; }
        public long Size { get => _size; set => _size = value; }

        public AlfaGenerationApplication(string name , string category , long size)
        {
            _name = name;
            _category = category;
            _size = size;
        }
        public void Use()
        {
            //Do stuff;
            Console.WriteLine($"{_name} is used!");
        }
        public void Open()
        {
            Console.WriteLine($"{_name} is open");
        }
    }
    public class AlfaGenerationProperty : IDeviceProperty
    {
        private string _Name;
        private string _Description;
        private string _Value;

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public object TryGet()
        {
            throw new NotImplementedException();
        }

        public void TrySet(object value)
        {
            throw new NotImplementedException();
        }
    }
}
