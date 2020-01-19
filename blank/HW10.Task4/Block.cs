using System;
using System.Collections.Generic;
using System.Text;

namespace HW10.Task4
{
    class Block
    {
        int[] array = new int[3];
        int _width;
        int _length;
        int _height;

        public Block(int[] arr)
        {
            array = arr;
            _width = array[0];
            _length = array[1];
            _height = array[2];
        }
        public int GetWidth()
        {
            Console.WriteLine($"width:{_width}");
            return _width;
        }
        public int GetLength()
        {
            Console.WriteLine($"length: {_length}");
            return _length;
        }
        public int GetHeight()
        {
            Console.WriteLine($"height: {_height}");
            return _height;
        }
        public int GetVolume()
        {
            Console.WriteLine($"volume: {_width * _length * _height}");
            return _width * _length *_height;
        }
        public int GetSutfaceArea()
        {
            Console.WriteLine($"surface area: {(_width * _length) * 2 + (_length * _height) * 2 + (_height * _width) * 2}");
            return (_width*_length)*2+(_length*_height)*2+(_height*_width)*2;
        }
    }
}
