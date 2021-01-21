using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SpaDay.Models
{
    public class Client
    {
        public string SkinType { get; set; }
        public string NailService { get; set; }
        private List<string> appropriateFacials = new List<string>();

        public Client(string skinType, string nailService)
        {
            SkinType = skinType;
            NailService = nailService;
        }

        public List<string> GetFacials()
        {
            return appropriateFacials;
        }

        public bool CheckSkinType(string skinType, string facialType)
        {

            if (skinType == "oily")
            {
                if (facialType == "Microdermabrasion" || facialType == "Rejuvenating")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (skinType == "combination")
            {
                if (facialType == "Microdermabrasion" || facialType == "Rejuvenating" || facialType == "Enzyme Peel")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (skinType == "normal")
            {
                return true;
            }
            else if (skinType == "dry")
            {
                if (facialType == "Rejuvenating" || facialType == "Hydrofacial")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public void SetFacials(String skinType)
        {
            List<String> facials = new List<String>();
            facials.Add("Microdermabrasion");
            facials.Add("Hydrofacial");
            facials.Add("Rejuvenating");
            facials.Add("Enzyme Peel");

            foreach (string facial in facials)
            {
                if (CheckSkinType(skinType, facial))
                {
                    appropriateFacials.Add(facial);
                }
            }
        }
    }
}
