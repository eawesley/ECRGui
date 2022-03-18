using System;
using System.ComponentModel;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECRGui.Model
{
    public class PartModel : INotifyPropertyChanged
    {
        private ObjectId _partId;
        private string _number;
        private string _revision;
        private string _description;
        private DateTime _date;
        
        [BsonId] // _id field
        public ObjectId PartId
        {
            get => _partId;
            set
            {
                _partId = value;
                OnPropertyChanged("PartId");
            }
        }

        public string Number
        {
            get => _number;
            set
            {
                _number = value;
                OnPropertyChanged("PartNumber");
            }
        }

        public string Revision
        {
            get => _revision;
            set
            {
                _revision = value;
                OnPropertyChanged("PartRevision");
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged("PartDescription");
            }
        }

        public DateTime Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged("PartDate");
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