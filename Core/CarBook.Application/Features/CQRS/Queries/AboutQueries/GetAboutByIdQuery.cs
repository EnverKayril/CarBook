namespace CarBook.Application.Features.CQRS.Queries.AboutQueries
{
    public class GetAboutByIdQuery
    {
        public GetAboutByIdQuery(int id)
        {
            AboutId = id;
        }

        public int AboutId { get; set; }
    }
}
