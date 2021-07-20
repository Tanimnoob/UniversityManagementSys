using System;

namespace UniversityManagementSys
{
    public abstract class Person
    {
        private string name;
        private const float minAge = 0.1f;
        private float age;
        private DateTime minBirthDate = DateTime.Today;
        private DateTime birthDate;
        //private Address address;
        private string email;
        private string phone;

        protected Person()
        {
            this.name = "Unknown";
            this.age = minAge;
            this.birthDate = minBirthDate;
            this.email = "Unknown";
            this.phone = "Unknown";
        }
        protected Person(string name, float age, DateTime birthDate, string email, string phone)
        {
            bool objectBuildSuccessfull = true;
            if (name.Length > 1)
                this.name = name;
            else
                objectBuildSuccessfull = false;
            if (age < minAge)
                this.age = age;
            else
                objectBuildSuccessfull = false;
            this.birthDate = birthDate;
            this.email = email;
            this.phone = phone;
            if (objectBuildSuccessfull)
                Console.WriteLine("Successfully created object");
            // raise creationFailed exception
            else
                Console.WriteLine("Object creation Unsuccessfull");
            // invoke method to show error message to user that object creation failed
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public float Age
        {
            get { return age; }
            set { age = value; }
        }
        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }
        /*public Location Address
        {
            get { return address; }
            set { address = value; }
        }*/
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

    }
}
