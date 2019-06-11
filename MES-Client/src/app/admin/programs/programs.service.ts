import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Program } from 'src/app/models/program.model';

@Injectable({
  providedIn: 'root'
})
export class ProgramsService {

  constructor(private httpClient: HttpClient) { }

  getPrograms() {
    return this.httpClient.get<Program[]>(`${environment.baseUrl}/programs`);
  }

  createProgram(name: string) {
    return this.httpClient.post(`${environment.baseUrl}/programs`, {name: name});
  }

  deleteProgram(id: string) {
    return this.httpClient.delete(`${environment.baseUrl}/programs/${id}`);
  }
}
