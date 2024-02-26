using CharityTestCore.Models;
using CharityTestCore.Repository;
using CharityTestCore.Repository.EPT;
using DAL.DataBase;

namespace CharityTestCore.Service.EPT
{
    public interface IEPTService
    {
        int AddEptQuestion( string UserId, bool? HaveSkill_, bool? BeforeYouHaveJob_, bool? DoYouWantHaveJob_, byte S01_, byte S02_, byte S03_, byte S04_, byte S05_, byte S06_, byte S07_, byte S08_, byte S09_, byte S10_, byte S11_, byte S12_, byte S13_, byte S14_, byte S15_, byte S16_, byte S17_, byte S18_, byte S19_, byte S20_, byte S21_, byte S22_, byte S23_, byte S24_, byte S25_, byte S26_, byte S27_, byte S28_, byte S29_, byte S30_, byte S31_, byte S32_, byte S33_, byte S34_, byte S35_, byte S36_, byte S37_, byte S38_, byte S39_, byte S40_, byte S41_, byte S42_, byte S43_, byte S44_, byte S45_, byte S46_, byte S47_, byte S48_, byte S49_, byte S50_, byte S51_, byte S52_, byte S53_, byte S54_, byte S55_, byte S56_, byte S57_, byte S58_, byte S59_, byte S60_, byte S61_, byte S62_, byte S63_, byte S64_, byte S65_, byte S66_, byte S67_, byte S68_, byte S69_, byte S70_, byte S71_, byte S72_, byte S73_, byte S74_, byte S75_, byte S76_, byte S77_, byte S78_, byte S79_, byte S80_, byte S81_, byte S82_, byte S83_, byte S84_, byte S85_, byte S86_, byte S87_, byte S88_, byte S89_, byte S90_, byte S91_, byte S92_, byte S93_, byte S94_, byte S95_
 );
        EPTListPersonModel EptPersonList(Guid? id);

        EptQuestionList? EptPersonById(Guid? id );

        bool EptPersonDeleteById(Guid? ept);

        List<EPTQuizTextModel> EptQuizTextList();
        EptQuestionList? GetEptByUserId(string UserId);

    }
}
