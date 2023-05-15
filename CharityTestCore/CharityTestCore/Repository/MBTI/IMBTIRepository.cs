﻿using DAL.DataBase;

namespace CharityTestCore.Repository.MBTI
{
    public interface IMBTIRepository
    {

        IEnumerable<MBTIQuestionList> MBTIQuestionList { get; }

        IEnumerable<MBTIAnswerList> MBTIAnswerList { get; }

        void AddMBTIAnswerList(MBTIAnswerList item);

        void DelMBTIQuestion(MBTIAnswerList item);

        void SaveChanges();

    }
}
