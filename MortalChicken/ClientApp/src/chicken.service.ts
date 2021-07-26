import { Inject, Injectable } from "@angular/core";
import { Chicken } from "./chicken";
import { HttpClient } from "@angular/common/http";

@Injectable({
    providedIn: 'root'
})

export class ChickenService{
    constructor(private http: HttpClient){

    }

    getChickens(@Inject('BASE_URL') baseUrl: string): any{
        return this.http.get<Chicken[]>(baseUrl + "Chicken/AllChickens")
    }


}