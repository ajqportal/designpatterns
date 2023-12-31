﻿using DesignPattern.Structural.Proxy.Interfaces;
using DesignPattern.Structural.Proxy.Subjects;

namespace DesignPattern.Structural.Proxy.Proxies
{
    internal class ProxyImage : IImage
    {
        private RealImage _realImage;
        private string _filename;

        public ProxyImage(string filename)
        {
            _filename = filename;
        }

        public void Display()
        {
            if (_realImage == null)
            {
                _realImage = new RealImage(_filename);
            }
            _realImage.Display();
        }
    }
}
