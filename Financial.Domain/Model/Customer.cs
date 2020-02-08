using System;
using Framework.Core;

namespace Financial.Domain.Model
{
    public class Customer : EntityBase, IAggregateRoot
    {
        string firstName;
        string lastname;
        string nationCode;
        DateTime birthDate;
        string mobile;
        private int age;
        private bool gender;
        #region Properties

        public virtual string FirstName { get { return firstName; } }

        public virtual string Lastname
        {
            get { return lastname; }
        }

        public virtual int Age => age;
        public virtual bool Gender => gender;

        public virtual string NationCode
        {
            get { return nationCode; }
        }
        public virtual DateTime BirthDate
        {
            get { return birthDate; }
        }
        public virtual string Mobile
        {
            get { return mobile; }

        }

        public virtual Address HomeAddress { get; protected set; }
        public virtual Phone PhoneNumber { get; protected set; }

        #endregion

        public Customer()
        {

        }

        public Customer(string firstName, string lastName,bool gender,int age
            , Address homeAddress, string nationCode, DateTime birthDate, Phone phone, string mobile)
        {
            SetFirstName(firstName);
            SetLastName(lastName);
            SetNationCode(nationCode);
            SetAge(age);
            SetMobile(mobile);
            this.gender = gender;
            this.HomeAddress = homeAddress;
            this.birthDate = birthDate;
            this.PhoneNumber = phone;
        }
        private void SetFirstName(string firstName)
        {
            if (string.IsNullOrEmpty(firstName) && firstName.Length < 3)
            {
                throw new NotSupportedException();
            }
            this.firstName = firstName;

        }

        private void SetLastName(string lastName)
        {
            if (string.IsNullOrEmpty(lastName) && lastName.Length < 3)
            {
                throw new NotSupportedException();
            }
            this.lastname = lastName;

        }
        private void SetAge(int age)
        {
            if (age>=18)
            {
                throw new NotSupportedException();
            }
            this.age = age;

        }

        private void SetMobile(string mobile)
        {
            if (mobile != null && (string.IsNullOrEmpty(mobile) && mobile.Length ==11) && mobile.StartsWith("09") )
            {
                throw new NotSupportedException();
            }
            this.mobile = mobile;

        }
        private void SetNationCode(string nationCode)
        {
            if (nationCode != null && (string.IsNullOrEmpty(nationCode) && nationCode.Length < 3))
            {
                throw new NotSupportedException();
            }
            this.nationCode = nationCode;

        }
    }
}
