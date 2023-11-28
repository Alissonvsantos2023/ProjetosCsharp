﻿using Newtonsoft.Json;
namespace Trabalhoc_
{
    public class Resultado
    {
     
        [ JsonProperty(PropertyName = "cep")]
        public string CEP { get; set; }
        [JsonProperty(PropertyName = "logradouro")]
        public string Logradouro { get; set; }
        [JsonProperty(PropertyName = "complemento")]
        public string Complemento { get; set; }
        [JsonProperty(PropertyName = "bairro")]
        public string Bairro { get; set; }
        [JsonProperty(PropertyName = "localidade")]
        public string Localidade { get; set; }
        [JsonProperty(PropertyName = "uf")]
        public string UF { get; set; }
        [JsonProperty(PropertyName = "ibge")]
        public string IBGE { get; set; }
        [JsonProperty(PropertyName = "gia")]
        public string GIA { get; set; }
        [JsonProperty(PropertyName = "ddd")]
        public int DDD { get; set; }
        [JsonProperty(PropertyName = "siafi")]
        public int SIAFI { get; set; }
        

    }
}
