import { Address } from './address.model';
import { Workexperience } from './Workexperience.model';
import { Educationexperience } from './Educationexperience.model';

export class Person {
    
    Id: number;
    FirstName: string;
    LastName: string;
    PreferredName: string;
    PhoneNumber: string;
    Email: string;
    githubUsername: string;
    linkedInUsername: string;
    HomeAddress: Address;
    WorkExperiences: Workexperience[];
    EdcuationExperiences: Educationexperience[];

    
}
