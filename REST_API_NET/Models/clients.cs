namespace REST_API_NET.Models
{
    public class clients
    {
        private ClientsStoreContext context;  
  
        public int id { get; set; }  
  
        public string client_fullname { get; set; }  
  
        public string document_number { get; set; }  
  
        public int account_number { get; set; }  
  
        public string residue { get; set; }

    }
}
