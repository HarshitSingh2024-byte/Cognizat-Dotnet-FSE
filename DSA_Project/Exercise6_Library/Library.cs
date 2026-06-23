class Library
{


    // Linear Search

    public Book LinearSearch(Book[] books, string title)
    {

        for(int i = 0; i < books.Length; i++)
        {

            if(books[i].Title == title)
            {
                return books[i];
            }

        }

        return null;

    }

    // Binary Search
    // Books should be sorted by title

    public Book BinarySearch(Book[] books, string title)
    {
        int start = 0;
        int end = books.Length - 1;

       while(start <= end)
        {

            int middle = (start + end) / 2;

            if(books[middle].Title == title)
            {
                return books[middle];
            }

            if(books[middle].Title.CompareTo(title) < 0)
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