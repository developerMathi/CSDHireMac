using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxVonGrafKftMobileModel
{
    [Serializable]
    public class DefaultDamageList
    {

        public int QuestionID { get; set; }
        public int DefaultId { get; set; }
        public int clientID { get; set; }
        public string Description { get; set; }
        public string Area { get; set; }
        public string SelectOption { get; set; }
        public bool isOptional { get; set; }
        public string ControllerType { get; set; }
        public string optionType { get; set; }
        public int Action { get; set; }
        public bool IsChecked { get; set; }
        public int AnswerId { get; set; }
        public List<DefaultDamageList> DefaultDmgList { get; set; }
        public int UpdatedBy { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public MultipleChoice multiChoice { get; set; }
        public List<MultipleChoice> multiChoiceList { get; set; }
        public List<MultipleChoice> multiList { get; set; }
        public AnswerModel AnswerMode { get; set; }
        public bool CheckIn { get; set; }
        public bool checkout { get; set; }
        public bool IsActive { get; set; }
        public DateTime Calendar { get; set; }
        public string calendarstr { get; set; }
    }

    public class AnswerModel
    {
        public int AnswerID { get; set; }
        public int DefaultId { get; set; }
        public int ReferenceId { get; set; }
        public string ReferenceType { get; set; }
        public string Description { get; set; }
        public bool isOptional { get; set; }
        public string Area { get; set; }
        public string optionType { get; set; }
        public string SelectOption { get; set; }
        public string response { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Answer { get; set; }
        public List<AnswerModel> answerList { get; set; }
    }

    public class MultipleChoice
    {
        public int QuestionId { get; set; }
        public int multiid { get; set; }
        public string ButtonName { get; set; }
        public bool IsSelected { get; set; }
        public bool isOptional { get; set; }
        public List<MultipleChoice> MultipleList { get; set; }
        //public bool yes { get; set; }
        //public bool No { get; set; }
        //public int Count { get; set; }


    }

}