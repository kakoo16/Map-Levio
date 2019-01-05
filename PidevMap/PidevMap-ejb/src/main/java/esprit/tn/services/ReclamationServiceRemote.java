package esprit.tn.services;

import java.util.List;

import javax.ejb.Remote;

import esprit.tn.entities.Reclamation;

@Remote

public interface ReclamationServiceRemote {
public void ajouterReclamation(Reclamation e) ; 
public List<Reclamation> findAll() ; 
public void DeleteReclamationById(int ReclamationId) ; 
public Reclamation updaterec(Reclamation Reclamation);
}
