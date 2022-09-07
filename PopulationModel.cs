using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//namespace ModelThatJSONCorrectVersion
//{
//    class PopulationModel
//    {
//        public _PreyList[]? preyList { get; set; }
//        public _PredList[]? predList { get; set; }
//    }

//    public class _PreyList
//    {
//        public _Rabbit[]? rabbit { get; set; }
//        public _Deer[]? deer { get; set; }
//    }
//    public class _Rabbit
//    {
//        public string Species { get; set; } = string.Empty; // declare Species as an empty string
//        public int Id { get; set; }
//        public int Attack { get; set; }
//        public int Health { get; set; }
//        public int Speed { get; set; }
//    }
//    public class _Deer
//    {
//        public string Species { get; set; } = string.Empty;
//        public int Id { get; set; }
//        public int Attack { get; set; }
//        public int Health { get; set; }
//        public int Speed { get; set; }

//    }


//    public class _PredList
//    {
//        public _Wolf[]? wolf { get; set; }
//        public _Jaguar[]? jaguar { get; set; }
//    }

//    public class _Wolf
//    {
//        public string Species { get; set; } = string.Empty;
//        public int Id { get; set; }
//        public int Attack { get; set; }
//        public int Health { get; set; }
//        public int Speed { get; set; }
//    }
//    public class _Jaguar
//    {
//        public string Species { get; set; } = string.Empty;
//        public int Id { get; set; }
//        public int Attack { get; set; }
//        public int Health { get; set; }
//        public int Speed { get; set; }
//    }
//}


namespace ModelThatJSONCorrectVersion
{
    public class PopulationModel
    {
        public _PreyList[]? preyList { get; set; }
        public _PredList[]? predList { get; set; }
    }
    public class _PredList
    {
        public _Wolves[]? wolves { get; set; }
        public _Jaguar[]? jaguars { get; set; }
    }

    public class _Jaguar
    {
        public int id { get; set; }
        public int attack { get; set; }
        public int health { get; set; }
        public int speed { get; set; }
        public string guid { get; set; } = string.Empty;
    }
    public class _Wolves
    {
        public int id { get; set; }
        public int attack { get; set; }
        public int health { get; set; }
        public int speed { get; set; }
        public string guid { get; set; } = string.Empty;
    }
    public class _PreyList
    {
        public _Rabbits[]? rabbits { get; set; }
        public _Deer[]? deer { get; set; }
    }
    public class _Rabbits
    {
        public int id { get; set; }
        public int attack { get; set; }
        public int health { get; set; }
        public int speed { get; set; }
        public string guid { get; set; } = string.Empty;
    }
    public class _Deer
    {
        public int id { get; set; }
        public int attack { get; set; }
        public int health { get; set; }
        public int speed { get; set; }
        public string guid { get; set; } = string.Empty;
    }
}



