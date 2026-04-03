/// <summary>
/// Defines a contract for implementing Merge Sort on an array of Student objects.
/// Declares methods for performing the recursive merge sort operation and
/// merging two sorted subarrays into a single sorted array.
/// </summary>


interface IMerge
{
    void MergeSort(Student[] arr);
    void Merge(Student[] arr, Student[] left, Student[] right);
}

