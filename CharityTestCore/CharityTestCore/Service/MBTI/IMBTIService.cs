using CharityTestCore.Models;
using CharityTestCore.Repository.MBTI;
using DAL.DataBase;

namespace CharityTestCore.Service.MBTI
{
    public interface IMBTIService
    {
        MBTIQuestionListPersonModel MBTIPersonList(Guid? id);
        int AddMBTIQuestionList(Guid UserId, byte Answer1, byte Answer2, byte Answer3, byte Answer4, byte Answer5, byte Answer6, byte Answer7, byte Answer8, byte Answer9, byte Answer10, byte Answer11, byte Answer12, byte Answer13, byte Answer14, byte Answer15, byte Answer16, byte Answer17, byte Answer18, byte Answer19, byte Answer20, byte Answer21, byte Answer22, byte Answer23, byte Answer24, byte Answer25, byte Answer26, byte Answer27, byte Answer28, byte Answer29, byte Answer30, byte Answer31, byte Answer32, byte Answer33, byte Answer34, byte Answer35, byte Answer36, byte Answer37, byte Answer38, byte Answer39, byte Answer40, byte Answer41, byte Answer42, byte Answer43, byte Answer44, byte Answer45, byte Answer46, byte Answer47, byte Answer48, byte Answer49, byte Answer50, byte Answer51, byte Answer52, byte Answer53, byte Answer54, byte Answer55, byte Answer56, byte Answer57, byte Answer58, byte Answer59, byte Answer60, byte Answer61, byte Answer62, byte Answer63, byte Answer64, byte Answer65, byte Answer66, byte Answer67, byte Answer68, byte Answer69, byte Answer70, byte Answer71, byte Answer72, byte Answer73, byte Answer74, byte Answer75, byte Answer76, byte Answer77, byte Answer78, byte Answer79, byte Answer80);
        MBTIAnswerList? MBTIPersonById(Guid? id);
        bool MBTIPersonDeleteById(Guid? ept);
        MBTIAnswerList? GetByUserId(Guid UserId);
        int AddMBTIQuestionList(Guid userId, byte[] answers);
    }
}
