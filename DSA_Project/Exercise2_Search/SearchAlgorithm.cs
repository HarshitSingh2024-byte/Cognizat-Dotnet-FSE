class SearchAlgorithm
{

    // Linear Search
    public static Product LinearSearch(Product[] products, string name)
    {

        for(int i = 0; i < products.Length; i++)
        {

            if(products[i].ProductName == name)
            {
                return products[i];
            }

        }

        return null;
    }



    // Binary Search
    // Array must be sorted by ProductName
    public static Product BinarySearch(Product[] products, string name)
    {

        int start = 0;
        int end = products.Length - 1;


        while(start <= end)
        {

            int middle = (start + end) / 2;


            if(products[middle].ProductName == name)
            {
                return products[middle];
            }


            if(products[middle].ProductName.CompareTo(name) < 0)
            {
                start = middle + 1;
            }

            else
            {
                end = middle - 1;
            }

        }


        return null;
    }

}