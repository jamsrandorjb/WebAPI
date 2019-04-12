import { Address } from './address.model';

export class Workexperience {

        Id: number;
        CompanyName: string;
        PositionHeld: string;

        WorkAddress: Address;

        StartYear: string;
        StartMonth: string;
        StartDay: string;
        EndYear: string;
        EndMonth: string;
        EndDay: string;
        IsCurrent: boolean;
        Duties : string;
        JobType: JobTypeEnum;
}

enum JobTypeEnum {
    FullTime,
    PartTime,
    Volunteer,
    Internship
}
