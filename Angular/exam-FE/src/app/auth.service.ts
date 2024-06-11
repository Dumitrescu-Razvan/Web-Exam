import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  //TODO put the actual URL here
  private baseUrl = 'http://localhost:3000';

  constructor() { }

  login(username: string, password: string) {
    return fetch(`${this.baseUrl}/login`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify({ username, password })
      //! not sure if this is needed yet
      //! credentials: 'include' 
    });
  }

  register(username: string, password: string) {
    return fetch(`${this.baseUrl}/register`, {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify({ username, password })
      //! not sure if this is needed yet
      //! credentials: 'include'
    });
  }
}
