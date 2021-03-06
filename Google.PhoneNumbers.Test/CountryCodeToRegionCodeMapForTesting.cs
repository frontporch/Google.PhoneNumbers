/*
 * Copyright (C) 2014 The Libphonenumber Authors
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

/* This file is automatically generated by {@link BuildMetadataProtoFromXml}.
 * Please don't modify it directly.
 */

namespace Google.PhoneNumbers {

using System;
using System.Collections.Generic;

public class CountryCodeToRegionCodeMapForTesting {
  // A mapping from a country code to the region codes which denote the
  // country/region represented by that country code. In the case of multiple
  // countries sharing a calling code, such as the NANPA countries, the one
  // indicated with "isMainCountryForCode" in the metadata should be first.
  internal static Dictionary<int, List<String>> getCountryCodeToRegionCodeMap() {
    // The capacity is set to %d as there are %d different entries,
    // and this offers a load factor of roughly 0.75.
    Dictionary<int, List<String>> countryCodeToRegionCodeMap =
        new Dictionary<int, List<String>>(30);

    List<String> listWithRegionCode;

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("AD");
    countryCodeToRegionCodeMap.Add(376, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("AE");
    countryCodeToRegionCodeMap.Add(971, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("AO");
    countryCodeToRegionCodeMap.Add(244, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("AR");
    countryCodeToRegionCodeMap.Add(54, listWithRegionCode);

    listWithRegionCode = new List<String>(3);
    listWithRegionCode.Add("AU");
    listWithRegionCode.Add("CC");
    listWithRegionCode.Add("CX");
    countryCodeToRegionCodeMap.Add(61, listWithRegionCode);

    listWithRegionCode = new List<String>(4);
    listWithRegionCode.Add("US");
    listWithRegionCode.Add("BB");
    listWithRegionCode.Add("BS");
    listWithRegionCode.Add("CA");
    countryCodeToRegionCodeMap.Add(1, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("BR");
    countryCodeToRegionCodeMap.Add(55, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("BY");
    countryCodeToRegionCodeMap.Add(375, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("CN");
    countryCodeToRegionCodeMap.Add(86, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("DE");
    countryCodeToRegionCodeMap.Add(49, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("FR");
    countryCodeToRegionCodeMap.Add(33, listWithRegionCode);

    listWithRegionCode = new List<String>(2);
    listWithRegionCode.Add("GB");
    listWithRegionCode.Add("GG");
    countryCodeToRegionCodeMap.Add(44, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("HU");
    countryCodeToRegionCodeMap.Add(36, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("IT");
    countryCodeToRegionCodeMap.Add(39, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("JP");
    countryCodeToRegionCodeMap.Add(81, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("KR");
    countryCodeToRegionCodeMap.Add(82, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("MX");
    countryCodeToRegionCodeMap.Add(52, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("NZ");
    countryCodeToRegionCodeMap.Add(64, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("PL");
    countryCodeToRegionCodeMap.Add(48, listWithRegionCode);

    listWithRegionCode = new List<String>(2);
    listWithRegionCode.Add("RE");
    listWithRegionCode.Add("YT");
    countryCodeToRegionCodeMap.Add(262, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("SG");
    countryCodeToRegionCodeMap.Add(65, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("001");
    countryCodeToRegionCodeMap.Add(800, listWithRegionCode);

    listWithRegionCode = new List<String>(1);
    listWithRegionCode.Add("001");
    countryCodeToRegionCodeMap.Add(979, listWithRegionCode);

    return countryCodeToRegionCodeMap;
  }
}
}
