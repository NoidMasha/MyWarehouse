namespace Models
{
    public class Item : BaseEntity
    {
        public Item() : base()
        {
        }

        // **********
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 30, MinimumLength = 2)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = true)]
        public string EnglishName { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 30, MinimumLength = 2)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = true)]
        public string PersianName { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 13, MinimumLength = 13)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = true)]
        public string GeneralCode { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 30)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public string OrderCode { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public int CurrentQuantity { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = true)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public int UsedQuantity { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 20)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public string Type { get; set; }
        // **********

        // **********
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings = false)]

        [System.ComponentModel.DataAnnotations.StringLength
            (maximumLength: 20)]

        [System.ComponentModel.DataAnnotations.Schema.Index
            (IsUnique = false)]
        public string Address { get; set; }
        // **********

        


    }
}
