using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.PageOjects
{

    class ManCityObject

{
        public static string elementList1 =  "div.the_champ_sharing_container>ul.the_champ_sharing_ul>li>i"; 
        public static string elementList= "main article .entry-wrapper .entry-content p:nth-child(34) ~p strong"; 
        
        public static string css_txtAuthor= "p.comment-form-author>input"; 
        

        public static string css_txtEmail = "p.comment-form-email>input";
       

        public static string css_txtUrl = "p.comment-form-url>input"; 
        
        public static string css_txtComment = "p.comment-form-comment>textarea";
            
        
        public static string css_btnSubmit= "p.form-submit input[type=\"submit\"]"; 
        }
        
}
