using System;
using CensusAnalyser.poco;
using System.Collections.Generic;

namespace CensusAnalyser
{
    public class CensusAnalyser
    {
        public enum Country
        {
            INDIA,
        }

        Dictionary<string, CensusDTO> dataMap;

        public Dictionary<string, CensusDTO> LoadCensusData(Country country, string csvFilePath, string dataHeaders)
        {
            dataMap = new CSVAdapterFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return dataMap;
        }
    }

}
