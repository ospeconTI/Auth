using System;
using System.Collections.Generic;
using System.Linq;
using OSPeConTI.Auth.Services.Domain.SeedWork;

namespace OSPeConTI.Auth.Services.Domain.Entities {
    public class Origen : Enumeration {
        public static Origen SQL = new Origen(1, nameof(SQL).ToLowerInvariant());

        public static Origen AD = new Origen(2, nameof(AD).ToLowerInvariant());

        public static Origen SAP = new Origen(3, nameof(SAP).ToLowerInvariant());

        public Origen(int id, string nombre) : base(id, nombre) {
        }

        public static IEnumerable<Origen> List() => new[] { SQL, AD, SAP };

        public static Origen FromName(string nombre) {
            var state = List().SingleOrDefault(s => String.Equals(s.Nombre, nombre, StringComparison.CurrentCultureIgnoreCase));

            if (state == null) {
                throw new Exception($"Valores posibles para Origen: {String.Join(",", List().Select(s => s.Nombre))}");
            }

            return state;
        }

        public static Origen From(int id) {
            var state = List().SingleOrDefault(s => s.Id == id);

            if (state == null) {
                throw new Exception($"Valores posibles para Origen: {String.Join(",", List().Select(s => s.Nombre))}");
            }

            return state;
        }
    }
}
