using System;
using System.Collections.Generic;
using System.Reflection;

namespace SimpleTeam.GameOne.BinarySerialization
{
    
    using TypeID = Byte;
    /**
    <summary> 
    Реестр всех упаковщиков сообщений.
    </summary>
    */
    public class RegisterPacker
    {

        private Dictionary<TypeID, IPackerID> _dictionary;
        public RegisterPacker()
        {
            _dictionary = GetDictionary();
        }
        private Dictionary<TypeID, IPackerID> GetDictionary()
        {
            var assemblyType = typeof(Assembly);

            var packers = new Dictionary<TypeID, IPackerID>();
            foreach (var type in assemblyType.Assembly.GetTypes())
            {
                if (!type.IsClass)
                    continue;

                if (type.IsAbstract)
                    continue;


                if (typeof(IPackerID).IsAssignableFrom(type))
                {
                    IPackerID p = Activator.CreateInstance(type) as IPackerID;
                    packers.Add(p.Type, p);
                }
                    
            }

            return packers;
        }
        public IPackerID  Find(TypeID type)
        {
            if (_dictionary.ContainsKey(type))
                return _dictionary[type];
            return null;
        }
    }
}
