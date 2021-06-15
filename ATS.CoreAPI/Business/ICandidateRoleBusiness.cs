﻿using ATS.CoreAPI.Model.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATS.CoreAPI.Business
{
    public interface ICandidateRoleBusiness
    {
        CandidateRole Get(int id);

        List<CandidateRole> GetByCandidate(int candidateID);

        int Save(CandidateRole candidateRole);

        bool Delete(int id);

        bool DeleteByCandidateID(int candidateID);
    }
}
