namespace NavrhTrid
{
    /// <summary>
    /// zdroj firmy
    /// </summary>
    public interface ICompanyResource
    {
        /// <summary>
        /// Identifikator
        /// </summary>
        CompanyId CompanyId {get;}

        /// <summary>
        /// Hodnota v dolarech :-)
        /// </summary>
        /// <returns></returns>
        decimal GetValue();
    }
}