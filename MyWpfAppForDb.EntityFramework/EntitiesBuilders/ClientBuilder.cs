﻿using Microsoft.EntityFrameworkCore;
using MyWpfAppForDb.EntityFramework.Entities;

namespace MyWpfAppForDb.EntityFramework.EntitiesBuilders
{
	internal static class ClientBuilder
	{
		public static void ClientBuild(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Client>(entity =>
			{
				entity.Property(e => e.Id)
					.ValueGeneratedNever()
					.HasColumnName("client_id");

				entity.Property(e => e.Email)
					.HasMaxLength(100)
					.HasColumnName("email");

				entity.Property(e => e.Name)
					.HasMaxLength(100)
					.HasColumnName("name");

				entity.Property(e => e.Phone)
					.HasMaxLength(100)
					.HasColumnName("phone");
			});

			modelBuilder.Entity<Client>().HasData(
				new Client { Id = 1, Name = "Alice Johnson", Email = "alice.johnson@example.com", Phone = "123-456-7890" },
				new Client { Id = 2, Name = "Bob Smith", Email = "bob.smith@example.com", Phone = "456-789-0123" },
				new Client { Id = 3, Name = "Eva Williams", Email = "eva.williams@example.com", Phone = "789-012-3456" },
				new Client { Id = 4, Name = "Daniel Brown", Email = "daniel.brown@example.com", Phone = "012-345-6789" },
				new Client { Id = 5, Name = "Grace Miller", Email = "grace.miller@example.com", Phone = "345-678-9012" },
				new Client { Id = 6, Name = "Peter Davis", Email = "peter.davis@example.com", Phone = "678-901-2345" },
				new Client { Id = 7, Name = "Sophia Garcia", Email = "sophia.garcia@example.com", Phone = "901-234-5678" },
				new Client { Id = 8, Name = "Aiden Martinez", Email = "aiden.martinez@example.com", Phone = "234-567-8901" },
				new Client { Id = 9, Name = "Nora Wilson", Email = "nora.wilson@example.com", Phone = "567-890-1234" },
				new Client { Id = 10, Name = "Olivia Taylor", Email = "olivia.taylor@example.com", Phone = "890-123-4567" }
			);
		}
	}
}
