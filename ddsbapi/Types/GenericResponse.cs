namespace ddsbapi.Types
{
    /// <summary>
    /// The generic response.
    /// </summary>
    /// <typeparam name="TData">The type of <see cref="Data"/></typeparam>
    public class GenericResponse<TData> : BasicOkResponse
    {
        /// <summary>
        /// The data in <typeparamref name="TData"/>
        /// </summary>
        public TData Data { get; set; }
    }
}
