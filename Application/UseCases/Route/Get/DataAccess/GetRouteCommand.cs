namespace Application.UseCases.Route.Get.DataAccess
{
    public class GetRouteCommand
    {
        public static string AqlQuery = @"FOR p IN ANY K_SHORTEST_PATHS
                                                                   @from TO @to
                                                                   GRAPH 'Rideit'
                                                                   OPTIONS {weightAttribute: @preference,}
                                                                   LIMIT 2
                                                                   RETURN { Points: p.vertices[*], Segments: p.edges[*] }";
    }
}