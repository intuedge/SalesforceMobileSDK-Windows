﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Newtonsoft.Json;

namespace Salesforce.Sample.NativeSmartStoreSample.utilities
{
    public class Opportunity : INotifyPropertyChanged
    {

        private string _name;
        private string _id;
        private string _ownerId;
        private string _accountId;
        private double _amount;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
                NotifyPropertyChanged("Id");
            }
        }

        public string OwnerId
        {
            get { return _ownerId; }
            set
            {
                _ownerId = value;
                NotifyPropertyChanged("OwnerId");
            }
        }

        public string AccountId
        {
            get { return _accountId; }
            set
            {
                _accountId = value;
                NotifyPropertyChanged("AccountId");
            }
        }

        public double Amount
        {
            get { return _amount; }
            set
            {
                _amount = value;
                NotifyPropertyChanged("Amount");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
