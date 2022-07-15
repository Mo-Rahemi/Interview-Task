using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Taaghche.Infrastructure.Redis
{
    public class RedisContext
    {
        public ConnectionMultiplexer Redis { get; private set; }

        public RedisContext()
        {
            Redis = ConnectionMultiplexer.Connect("localhost");

        }
        public RedisContext(string ConnectionString)
        {
            Redis = ConnectionMultiplexer.Connect(ConnectionString);

        }
    }
}
