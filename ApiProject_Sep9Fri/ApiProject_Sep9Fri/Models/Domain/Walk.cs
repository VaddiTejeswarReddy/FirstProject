namespace ApiProject_Sep9Fri.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public Guid RegionId { get; set; }
        public Guid WalkDifficultyId { get; set; }

        //One-One Connection
        public WalkDifficulty WalkDifficultys { get; set; }
        public Region Regions { get; set; }
    }
}
