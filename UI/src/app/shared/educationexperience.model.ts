import { Address } from './address.model';

export class Educationexperience {
    Id: number;
    UniversityName: string;
    EduDegree: EducationDegree;
    EduField: string;
    GPA: number;
    AdditionalComment: string;
    UniversityAddress: Address;
    StartYear: string;
    StartMonth: string;
    StartDay: string;
    EndYear: string;
    EndMonth: string;
    EndDay: string;
    IsCurrent: boolean;
    


}
enum EducationDegree {
    MASTERS, BACHELORS, GENERALEDUCATION
}