import { HttpClient } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { Subscription } from "rxjs";
import { Farm } from "./farm";

@Injectable({
    providedIn: 'root'
})

export class FarmService{

  constructor(private http: HttpClient) { }

    getFarmsList(@Inject('BASE_URL') baseUrl: string): any{
        return this.http.get<Farm[]>(baseUrl + "/AllFarms")
    }

    getFarm(@Inject('BASE_URL') baseUrl: string, farmId: number): any{
        return this.http.get<Farm>(baseUrl + "/Id="+ farmId)
    }
}
