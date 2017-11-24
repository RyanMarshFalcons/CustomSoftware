using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Resources_Information.Data
{
    public enum Rating { Poor, Fair, Satisfactory, Good, Excellent};
    public class EmployeeRating
    {
        public Rating Attendance { get; set; }
        public Rating Attitude { get; set; }
        public Rating JobKnowledge { get; set; }
        public Rating Productivity { get; set; }
        public Rating CommunicationSkills { get; set; }

        public int TotalRating()
        {
            return RatingToNumericValue(Attendance) + RatingToNumericValue(Attitude) + RatingToNumericValue(JobKnowledge) + RatingToNumericValue(Productivity) + RatingToNumericValue(CommunicationSkills);
        }

        public int RatingToNumericValue(Rating rating)
        {
            switch (rating)
            {
                case Rating.Poor:
                    return 0;
                    break;
                case Rating.Fair:
                    return 5;
                    break;
                case Rating.Satisfactory:
                    return 10;
                    break;
                case Rating.Good:
                    return 15;
                    break;
                case Rating.Excellent:
                default:
                    return 20;
                    break;
            }
        }
    }
}
