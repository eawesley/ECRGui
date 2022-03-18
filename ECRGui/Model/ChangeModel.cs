using System;
using System.ComponentModel;
using ECRGui.Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECRGui.Model
{
    public class ChangeModel : INotifyPropertyChanged
    {
        private ObjectId _changeId;
        private PartModel _part;
        private string _description;

        [BsonId] // _id field
        public ObjectId ChangeId
        {
            get => _changeId;
            set
            {
                _changeId = value;
                OnPropertyChanged("ChangeId");
            }
        }

        public PartModel Part
        {
            get => _part;
            set
            {
                _part = value;
                OnPropertyChanged("ChangePart");
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged("ChangeDescription");
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