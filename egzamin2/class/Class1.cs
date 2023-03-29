using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Text;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
namespace egzamin2
{
    public class Gallery
    {
        private List<Image> images;
        private int currentImageIndex;

        public Gallery(List<Image> images)
        {
            this.images = images;
            currentImageIndex = 0;
        }

        public Image GetCurrentImage()
        {
            return images[currentImageIndex];
        }

        public void MoveNext()
        {
            currentImageIndex = (currentImageIndex + 1) % images.Count;
        }

        public void MovePrevious()
        {
            currentImageIndex = (currentImageIndex - 1 + images.Count) % images.Count;
        }
    }

}
