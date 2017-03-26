﻿namespace codefirst.Models
{
    public class Review
    {
        public int ReviewId { get; set; }

        public int ProductId { get; set; }

  
        public string Title { get; set; }

        public string Description { get; set; }

        public string Description1 { get; set; }

        public string Description2 { get; set; }


        //Navigation Property
        public Product Product { get; set; }
    }
}