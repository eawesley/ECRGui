using System;
using System.Collections.Generic;
using System.ComponentModel;
using ECRGui.Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECRGui.Model
{
    public class EcrModel : INotifyPropertyChanged
    {
        private ObjectId _ecrId;
        private string _number;
        private string _description;
        private List<ChangeModel> _changes;

        [BsonId] // _id field
        public ObjectId EcrId
        {
            get => _ecrId;
            set
            {
                _ecrId = value;
                OnPropertyChanged("EcrId");
            }
        }

        public string Number
        {
            get => _number;
            set
            {
                _number = value;
                OnPropertyChanged("EcrNumber");
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged("EcrDescription");
            }
        }

        public List<ChangeModel> Changes
        {
            get => _changes;
            set
            {
                _changes = value;
                OnPropertyChanged("EcrChanges");
            }
        }
        
        #region INotifyPropertyChanged Members  
  
        public event PropertyChangedEventHandler PropertyChanged;  
        private void OnPropertyChanged(string propertyName)  
        {  
            if (PropertyChanged != null)  
            {  
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));  
            }  
        }  
        #endregion  
    }
}