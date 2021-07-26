import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Chicken } from './chicken';

@Injectable({
    providedIn: 'root'
  })

export class ChickenService{
    constructor(private http: HttpClient) {

    }

getChickensList(@Inject('BASE_URL') baseUrl: string): any {
    return this.http.get<Chicken[]>(baseUrl + 'Chicken/AllChickens');
}

}