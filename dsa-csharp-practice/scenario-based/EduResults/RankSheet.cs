/// <summary>
/// Manages multiple district results and generates a consolidated rank sheet.
/// Collects students from all districts into a single array, sorts them using
/// Merge Sort based on their scores, and returns the final ranked student list.
/// </summary>


using System;

class RankSheet
{
    private DistrictResult[] DistrictResults;

    public RankSheet(DistrictResult[] districtResults)
    {
        DistrictResults = districtResults;
    }
    public Student[] GenerateRankSheet()
    {
        int totalStudents = 0;
        for (int i = 0; i < DistrictResults.Length; i++)
        {
            totalStudents += DistrictResults[i].Size();
        }
        Student[] allStudents = new Student[totalStudents];

        int index = 0;
        for (int i = 0; i < DistrictResults.Length; i++)
        {
            Student[] temp = DistrictResults[i].Students1;
            for (int j = 0; j < DistrictResults.Length; j++)
            {
                allStudents[index++] = temp[j];
            }
        }
        IMerge merge = new MergeSortUtility();
        merge.MergeSort(allStudents);
        return allStudents;
    }
}
