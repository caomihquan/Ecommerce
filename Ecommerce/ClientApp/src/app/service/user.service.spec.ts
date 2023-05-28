import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable, catchError, map, of } from "rxjs";

declare type LoginResponse = {
  token: string;
};

@Injectable({
  providedIn: "root",
})
export class UserService {
  constructor(private _httpClient: HttpClient) {}

  login(username: string, password: string): Observable<LoginResponse> {
    return this._httpClient.post<LoginResponse>("api/auth/login", {
      username,
      password,
    }).pipe(
      map(x=>x),
      catchError((err: { statusCode: string }) =>
        of({
          token: "",
        })),
      );
  }
}
