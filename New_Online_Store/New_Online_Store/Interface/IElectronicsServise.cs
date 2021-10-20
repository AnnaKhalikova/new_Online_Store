namespace New_Online_Store.Interface
{
    public interface IElectronicsServise : IRepository<IElectronicsGeneralView>
    {
        public IElectronicsGeneralView GetNameByModel(string model);
    }
}
