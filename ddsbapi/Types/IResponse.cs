namespace ddsbapi.Types
{
    /// <summary>
    /// The response interface.
    /// </summary>
    public interface IResponse
    {
        /// <summary>
        /// Is this request succeed?
        /// </summary>
        public bool Success { get; }
    }
}
