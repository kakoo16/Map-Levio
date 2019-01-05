package esprit.tn.services;

import java.util.List;

import javax.ejb.LocalBean;
import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import esprit.tn.entities.Reclamation;

@Stateless
@LocalBean

public class ReclamationService implements ReclamationServiceRemote {

	@PersistenceContext
	EntityManager em;
	@Override
	public void ajouterReclamation(Reclamation e) {
		em.persist(e);	
	}

	@Override
	public List<Reclamation> findAll() {

		return em.createQuery("from Reclamation" ,Reclamation.class).getResultList();
	}
	
	@Override
	public void DeleteReclamationById(int ReclamationId) {
		em.remove(em.find(Reclamation.class,ReclamationId));
		
	}
	@Override
	public Reclamation updaterec(Reclamation Reclamation) {
		Reclamation = em.merge(Reclamation);	
		return Reclamation;
	}



	
}
