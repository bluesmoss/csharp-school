using System;

namespace CoreSchool.Entities
{
    public class BaseSchoolObject
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }

        public BaseSchoolObject()
        {
            UniqueId = Guid.NewGuid().ToString();
        }
    }
}