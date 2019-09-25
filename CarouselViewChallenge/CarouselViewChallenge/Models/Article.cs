using System.ComponentModel;

namespace CarouselViewChallenge.Models
{
    public class Article : INotifyPropertyChanged
    {
        #region Properties
        private string title;
        public string Article_title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
                onPropertyChange("Article_title");
            }
        }

        private string imageurl;
        public string Image
        {
            get
            {
                return imageurl;
            }
            set
            {
                imageurl = value;
                onPropertyChange("Image");
            }
        }

        private string category;
        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
                onPropertyChange("Category");
            }
        }

        private string content;
        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
                onPropertyChange("Content");
            }
        }
        #endregion

        public Article()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void onPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
