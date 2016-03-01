﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace CellularAutomaton
{
    /// <summary>
    /// Contains various static methods for serializing objects.
    /// </summary>
    public static class Serialization
    {
        /// <summary>
        /// Serializes an object of type "T" to a file
        /// </summary>
        public static void SerializeObject<T>(string FileName, T ObjectToSerialize)
        {
            Stream stream = File.Open(FileName, FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, ObjectToSerialize);
            stream.Close();
        }

        /// <summary>
        /// Deserializes an object of type "T" from a file
        /// </summary>
        public static T DeserializeObject<T>(string FileName)
        {
            T ObjectToDeserialize;
            Stream stream = File.Open(FileName, FileMode.Open);
            BinaryFormatter bFormatter = new BinaryFormatter();
            ObjectToDeserialize = (T)bFormatter.Deserialize(stream);
            stream.Close();
            return ObjectToDeserialize;
        }
    }
}