﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItechSupEDT.Modele
{
    public interface Destinataire
    {
        List<Session> GetSessions(DateTime dateDebut, DateTime dateFin);
    }
}
