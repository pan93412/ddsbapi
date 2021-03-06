﻿using Microsoft.EntityFrameworkCore;

namespace ddsbapi.Model
{
    /// <summary>
    /// The model for dd.sb API
    /// </summary>
    public class DDSBContext : DbContext
    {
        /// <summary>
        /// The storage for the shorten URLs.
        /// </summary>
        public DbSet<Link> Link { get; set; }
        /// <summary>
        /// The storage for the statistics of shorten URLs.
        /// </summary>
        public DbSet<Stat> Stat { get; set; }

        /// <inheritdoc/>
        public DDSBContext(DbContextOptions<DDSBContext> ctx) : base(ctx) { }
    }
}
