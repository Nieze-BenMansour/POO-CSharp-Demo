namespace EnumDemo;

/// <summary>
/// Famille des etres vivants.
/// </summary>
/// <typeparam name="T">Doit etre vivant.</typeparam>
public class Family<T> where T : IEtreViavant
{
    public string Name { get; set; }

    public IEnumerable<T> Members { get; set; }

    public IEnumerable<T> GetActiveMembers()
    {
      //  var activeMembers = new List<T>();

        foreach (var member in Members)
        {
            if (member.Energie > 10)
            {
                // Traitement complex
                yield return member;
            }
        }

        //return Members.Where(x => x.Energie);

       // return activeMembers;
    }
}
