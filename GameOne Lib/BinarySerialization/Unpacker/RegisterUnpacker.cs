using System;
using System.Collections.Generic;
using System.Reflection;

namespace SimpleTeam.GameOne.BinarySerialization
{
    using TypeID = Byte;
    /**
    <summary> 
    Реестр всех распаковщиков пакетов.
    </summary>
    */
    public class RegisterUnpacker
    {
        private Dictionary<TypeID, IUnpackerID> _dictionary;

        public RegisterUnpacker()
        {
            _dictionary = GetDictionary();
        }
        private Dictionary<TypeID, IUnpackerID> GetDictionary()
        {
            var assemblyType = typeof(Assembly);

            var packers = new Dictionary<TypeID, IUnpackerID>();
            foreach (var type in assemblyType.Assembly.GetTypes())
            {
                if (!type.IsClass)
                    continue;

                if (type.IsAbstract)
                    continue;


                if (typeof(IUnpackerID).IsAssignableFrom(type))
                {
                    IUnpackerID p = Activator.CreateInstance(type) as IUnpackerID;
                    packers.Add(p.Type, p);
                }

            }

            return packers;
        }
        public IUnpackerID Find(TypeID type)
        {
            if (_dictionary.ContainsKey(type))
                return _dictionary[type];
            return null;
        }
    }
}
