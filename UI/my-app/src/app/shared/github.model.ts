import { Injectable } from '@angular/core';

@Injectable({
    providedIn: 'root'
})

export class Github {
    Id: number;
    name: string;
    description: string;
    private_repo: Boolean;
    created_at: Date;
    git_url:string;
}